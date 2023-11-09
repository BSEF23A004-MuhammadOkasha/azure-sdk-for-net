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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityConnectorApplicationResource" /> and their operations.
    /// Each <see cref="SecurityConnectorApplicationResource" /> in the collection will belong to the same instance of <see cref="SecurityConnectorResource" />.
    /// To get a <see cref="SecurityConnectorApplicationCollection" /> instance call the GetSecurityConnectorApplications method from an instance of <see cref="SecurityConnectorResource" />.
    /// </summary>
    public partial class SecurityConnectorApplicationCollection : ArmCollection, IEnumerable<SecurityConnectorApplicationResource>, IAsyncEnumerable<SecurityConnectorApplicationResource>
    {
        private readonly ClientDiagnostics _securityConnectorApplicationClientDiagnostics;
        private readonly SecurityConnectorApplicationsRestOperations _securityConnectorApplicationRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorApplicationCollection"/> class for mocking. </summary>
        protected SecurityConnectorApplicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityConnectorApplicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityConnectorApplicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityConnectorApplicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecurityConnectorApplicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityConnectorApplicationResource.ResourceType, out string securityConnectorApplicationApiVersion);
            _securityConnectorApplicationRestClient = new SecurityConnectorApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityConnectorApplicationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SecurityConnectorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SecurityConnectorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or update a security Application on the given security connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityConnectorApplicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityConnectorApplicationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityConnectorApplicationResource>(Response.FromValue(new SecurityConnectorApplicationResource(Client, response), response.GetRawResponse()));
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
        /// Creates or update a security Application on the given security connector.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityConnectorApplicationResource> CreateOrUpdate(WaitUntil waitUntil, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityConnectorApplicationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityConnectorApplicationResource>(Response.FromValue(new SecurityConnectorApplicationResource(Client, response), response.GetRawResponse()));
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
        /// Get a specific application for the requested scope by applicationId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<Response<SecurityConnectorApplicationResource>> GetAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityConnectorApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific application for the requested scope by applicationId
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual Response<SecurityConnectorApplicationResource> Get(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.Get");
            scope.Start();
            try
            {
                var response = _securityConnectorApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of all relevant applications over a security connector level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityConnectorApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityConnectorApplicationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorApplicationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorApplicationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SecurityConnectorApplicationResource(Client, SecurityApplicationData.DeserializeSecurityApplicationData(e)), _securityConnectorApplicationClientDiagnostics, Pipeline, "SecurityConnectorApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of all relevant applications over a security connector level scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityConnectorApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityConnectorApplicationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityConnectorApplicationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityConnectorApplicationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SecurityConnectorApplicationResource(Client, SecurityApplicationData.DeserializeSecurityApplicationData(e)), _securityConnectorApplicationClientDiagnostics, Pipeline, "SecurityConnectorApplicationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityConnectorApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual Response<bool> Exists(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityConnectorApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityConnectorApplicationResource>> GetIfExistsAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityConnectorApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorApplicationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/securityConnectors/{securityConnectorName}/providers/Microsoft.Security/applications/{applicationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityConnectorApplications_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public virtual NullableResponse<SecurityConnectorApplicationResource> GetIfExists(string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var scope = _securityConnectorApplicationClientDiagnostics.CreateScope("SecurityConnectorApplicationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityConnectorApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, applicationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityConnectorApplicationResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityConnectorApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityConnectorApplicationResource> IEnumerable<SecurityConnectorApplicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityConnectorApplicationResource> IAsyncEnumerable<SecurityConnectorApplicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
