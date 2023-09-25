// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSparkConfigurationResource" /> and their operations.
    /// Each <see cref="SynapseSparkConfigurationResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseSparkConfigurationCollection" /> instance call the GetSynapseSparkConfigurations method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseSparkConfigurationCollection : ArmCollection, IEnumerable<SynapseSparkConfigurationResource>, IAsyncEnumerable<SynapseSparkConfigurationResource>
    {
        private readonly ClientDiagnostics _synapseSparkConfigurationSparkConfigurationClientDiagnostics;
        private readonly SparkConfigurationRestOperations _synapseSparkConfigurationSparkConfigurationRestClient;
        private readonly ClientDiagnostics _synapseSparkConfigurationSparkConfigurationsClientDiagnostics;
        private readonly SparkConfigurationsRestOperations _synapseSparkConfigurationSparkConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSparkConfigurationCollection"/> class for mocking. </summary>
        protected SynapseSparkConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSparkConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSparkConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSparkConfigurationSparkConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSparkConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSparkConfigurationResource.ResourceType, out string synapseSparkConfigurationSparkConfigurationApiVersion);
            _synapseSparkConfigurationSparkConfigurationRestClient = new SparkConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSparkConfigurationSparkConfigurationApiVersion);
            _synapseSparkConfigurationSparkConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSparkConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSparkConfigurationResource.ResourceType, out string synapseSparkConfigurationSparkConfigurationsApiVersion);
            _synapseSparkConfigurationSparkConfigurationsRestClient = new SparkConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSparkConfigurationSparkConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get SparkConfiguration by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual async Task<Response<SynapseSparkConfigurationResource>> GetAsync(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSparkConfigurationSparkConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SparkConfiguration by name in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual Response<SynapseSparkConfigurationResource> Get(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSparkConfigurationSparkConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List sparkConfigurations in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfigurations_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseSparkConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseSparkConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSparkConfigurationSparkConfigurationsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSparkConfigurationSparkConfigurationsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseSparkConfigurationResource(Client, SynapseSparkConfigurationData.DeserializeSynapseSparkConfigurationData(e)), _synapseSparkConfigurationSparkConfigurationsClientDiagnostics, Pipeline, "SynapseSparkConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List sparkConfigurations in a workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfigurations_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseSparkConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseSparkConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSparkConfigurationSparkConfigurationsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSparkConfigurationSparkConfigurationsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseSparkConfigurationResource(Client, SynapseSparkConfigurationData.DeserializeSynapseSparkConfigurationData(e)), _synapseSparkConfigurationSparkConfigurationsClientDiagnostics, Pipeline, "SynapseSparkConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSparkConfigurationSparkConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSparkConfigurationSparkConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<SynapseSparkConfigurationResource>> GetIfExistsAsync(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseSparkConfigurationSparkConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSparkConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sparkconfigurations/{sparkConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SparkConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sparkConfigurationName"> SparkConfiguration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sparkConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkConfigurationName"/> is null. </exception>
        public virtual NullableResponse<SynapseSparkConfigurationResource> GetIfExists(string sparkConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sparkConfigurationName, nameof(sparkConfigurationName));

            using var scope = _synapseSparkConfigurationSparkConfigurationClientDiagnostics.CreateScope("SynapseSparkConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseSparkConfigurationSparkConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sparkConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSparkConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSparkConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseSparkConfigurationResource> IEnumerable<SynapseSparkConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseSparkConfigurationResource> IAsyncEnumerable<SynapseSparkConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
