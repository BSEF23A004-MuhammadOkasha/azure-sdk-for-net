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

namespace Azure.ResourceManager.Datadog
{
    /// <summary>
    /// A class representing a collection of <see cref="DatadogSingleSignOnResource" /> and their operations.
    /// Each <see cref="DatadogSingleSignOnResource" /> in the collection will belong to the same instance of <see cref="DatadogMonitorResource" />.
    /// To get a <see cref="DatadogSingleSignOnResourceCollection" /> instance call the GetDatadogSingleSignOnResources method from an instance of <see cref="DatadogMonitorResource" />.
    /// </summary>
    public partial class DatadogSingleSignOnResourceCollection : ArmCollection, IEnumerable<DatadogSingleSignOnResource>, IAsyncEnumerable<DatadogSingleSignOnResource>
    {
        private readonly ClientDiagnostics _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics;
        private readonly SingleSignOnConfigurationsRestOperations _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatadogSingleSignOnResourceCollection"/> class for mocking. </summary>
        protected DatadogSingleSignOnResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatadogSingleSignOnResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatadogSingleSignOnResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Datadog", DatadogSingleSignOnResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatadogSingleSignOnResource.ResourceType, out string datadogSingleSignOnResourceSingleSignOnConfigurationsApiVersion);
            _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient = new SingleSignOnConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, datadogSingleSignOnResourceSingleSignOnConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DatadogMonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DatadogMonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Configures single-sign-on for this resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="data"> The DatadogSingleSignOnResourceData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatadogSingleSignOnResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationName, DatadogSingleSignOnResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DatadogArmOperation<DatadogSingleSignOnResource>(new DatadogSingleSignOnResourceOperationSource(Client), _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics, Pipeline, _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Configures single-sign-on for this resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="data"> The DatadogSingleSignOnResourceData to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatadogSingleSignOnResource> CreateOrUpdate(WaitUntil waitUntil, string configurationName, DatadogSingleSignOnResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data, cancellationToken);
                var operation = new DatadogArmOperation<DatadogSingleSignOnResource>(new DatadogSingleSignOnResourceOperationSource(Client), _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics, Pipeline, _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the datadog single sign-on resource for the given Monitor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<DatadogSingleSignOnResource>> GetAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatadogSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the datadog single sign-on resource for the given Monitor.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<DatadogSingleSignOnResource> Get(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatadogSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the single sign-on configurations for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatadogSingleSignOnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatadogSingleSignOnResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DatadogSingleSignOnResource(Client, DatadogSingleSignOnResourceData.DeserializeDatadogSingleSignOnResourceData(e)), _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics, Pipeline, "DatadogSingleSignOnResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the single sign-on configurations for a given monitor resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatadogSingleSignOnResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatadogSingleSignOnResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DatadogSingleSignOnResource(Client, DatadogSingleSignOnResourceData.DeserializeDatadogSingleSignOnResourceData(e)), _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics, Pipeline, "DatadogSingleSignOnResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<DatadogSingleSignOnResource>> GetIfExistsAsync(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DatadogSingleSignOnResource>(response.GetRawResponse());
                return Response.FromValue(new DatadogSingleSignOnResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Datadog/monitors/{monitorName}/singleSignOnConfigurations/{configurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SingleSignOnConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationName"> Configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationName"/> is null. </exception>
        public virtual NullableResponse<DatadogSingleSignOnResource> GetIfExists(string configurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationName, nameof(configurationName));

            using var scope = _datadogSingleSignOnResourceSingleSignOnConfigurationsClientDiagnostics.CreateScope("DatadogSingleSignOnResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _datadogSingleSignOnResourceSingleSignOnConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DatadogSingleSignOnResource>(response.GetRawResponse());
                return Response.FromValue(new DatadogSingleSignOnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatadogSingleSignOnResource> IEnumerable<DatadogSingleSignOnResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatadogSingleSignOnResource> IAsyncEnumerable<DatadogSingleSignOnResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
