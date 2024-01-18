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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorCustomDomainResource"/> and their operations.
    /// Each <see cref="FrontDoorCustomDomainResource"/> in the collection will belong to the same instance of <see cref="ProfileResource"/>.
    /// To get a <see cref="FrontDoorCustomDomainCollection"/> instance call the GetFrontDoorCustomDomains method from an instance of <see cref="ProfileResource"/>.
    /// </summary>
    public partial class FrontDoorCustomDomainCollection : ArmCollection, IEnumerable<FrontDoorCustomDomainResource>, IAsyncEnumerable<FrontDoorCustomDomainResource>
    {
        private readonly ClientDiagnostics _frontDoorCustomDomainClientDiagnostics;
        private readonly FrontDoorCustomDomainsRestOperations _frontDoorCustomDomainRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorCustomDomainCollection"/> class for mocking. </summary>
        protected FrontDoorCustomDomainCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorCustomDomainCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorCustomDomainCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorCustomDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorCustomDomainResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorCustomDomainResource.ResourceType, out string frontDoorCustomDomainApiVersion);
            _frontDoorCustomDomainRestClient = new FrontDoorCustomDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorCustomDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new domain within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="data"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorCustomDomainResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string customDomainName, FrontDoorCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorCustomDomainResource>(new FrontDoorCustomDomainOperationSource(Client), _frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new domain within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="data"> Domain properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorCustomDomainResource> CreateOrUpdate(WaitUntil waitUntil, string customDomainName, FrontDoorCustomDomainData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, data, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorCustomDomainResource>(new FrontDoorCustomDomainOperationSource(Client), _frontDoorCustomDomainClientDiagnostics, Pipeline, _frontDoorCustomDomainRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorCustomDomainResource>> GetAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing AzureFrontDoor domain with the specified domain name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<FrontDoorCustomDomainResource> Get(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists existing AzureFrontDoor domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorCustomDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorCustomDomainResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorCustomDomainRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorCustomDomainRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorCustomDomainResource(Client, FrontDoorCustomDomainData.DeserializeFrontDoorCustomDomainData(e)), _frontDoorCustomDomainClientDiagnostics, Pipeline, "FrontDoorCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists existing AzureFrontDoor domains.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_ListByProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorCustomDomainResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorCustomDomainResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorCustomDomainRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorCustomDomainRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorCustomDomainResource(Client, FrontDoorCustomDomainData.DeserializeFrontDoorCustomDomainData(e)), _frontDoorCustomDomainClientDiagnostics, Pipeline, "FrontDoorCustomDomainCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual Response<bool> Exists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontDoorCustomDomainResource>> GetIfExistsAsync(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontDoorCustomDomainRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/customDomains/{customDomainName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorCustomDomains_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontDoorCustomDomainResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="customDomainName"> Name of the domain under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="customDomainName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="customDomainName"/> is null. </exception>
        public virtual NullableResponse<FrontDoorCustomDomainResource> GetIfExists(string customDomainName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(customDomainName, nameof(customDomainName));

            using var scope = _frontDoorCustomDomainClientDiagnostics.CreateScope("FrontDoorCustomDomainCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontDoorCustomDomainRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, customDomainName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorCustomDomainResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorCustomDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorCustomDomainResource> IEnumerable<FrontDoorCustomDomainResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorCustomDomainResource> IAsyncEnumerable<FrontDoorCustomDomainResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
