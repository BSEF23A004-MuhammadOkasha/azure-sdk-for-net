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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="TargetTypeResource"/> and their operations.
    /// Each <see cref="TargetTypeResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="TargetTypeCollection"/> instance call the GetTargetTypes method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class TargetTypeCollection : ArmCollection, IEnumerable<TargetTypeResource>, IAsyncEnumerable<TargetTypeResource>
    {
        private readonly ClientDiagnostics _targetTypeClientDiagnostics;
        private readonly TargetTypesRestOperations _targetTypeRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="TargetTypeCollection"/> class for mocking. </summary>
        protected TargetTypeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TargetTypeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> String that represents a Location resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        internal TargetTypeCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _targetTypeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", TargetTypeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TargetTypeResource.ResourceType, out string targetTypeApiVersion);
            _targetTypeRestClient = new TargetTypesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, targetTypeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<Response<TargetTypeResource>> GetAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.Get");
            scope.Start();
            try
            {
                var response = await _targetTypeRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual Response<TargetTypeResource> Get(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.Get");
            scope.Start();
            try
            {
                var response = _targetTypeRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TargetTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TargetTypeResource> GetAllAsync(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _targetTypeRestClient.CreateListRequest(Id.SubscriptionId, _locationName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _targetTypeRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _locationName, continuationToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TargetTypeResource(Client, TargetTypeData.DeserializeTargetTypeData(e)), _targetTypeClientDiagnostics, Pipeline, "TargetTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of Target Type resources for given location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="continuationToken"> String that sets the continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TargetTypeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TargetTypeResource> GetAll(string continuationToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _targetTypeRestClient.CreateListRequest(Id.SubscriptionId, _locationName, continuationToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _targetTypeRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _locationName, continuationToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TargetTypeResource(Client, TargetTypeData.DeserializeTargetTypeData(e)), _targetTypeClientDiagnostics, Pipeline, "TargetTypeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _targetTypeRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual Response<bool> Exists(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.Exists");
            scope.Start();
            try
            {
                var response = _targetTypeRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual async Task<NullableResponse<TargetTypeResource>> GetIfExistsAsync(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _targetTypeRestClient.GetAsync(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<TargetTypeResource>(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Chaos/locations/{locationName}/targetTypes/{targetTypeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TargetTypes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TargetTypeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="targetTypeName"> String that represents a Target Type resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="targetTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="targetTypeName"/> is null. </exception>
        public virtual NullableResponse<TargetTypeResource> GetIfExists(string targetTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(targetTypeName, nameof(targetTypeName));

            using var scope = _targetTypeClientDiagnostics.CreateScope("TargetTypeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _targetTypeRestClient.Get(Id.SubscriptionId, _locationName, targetTypeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<TargetTypeResource>(response.GetRawResponse());
                return Response.FromValue(new TargetTypeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TargetTypeResource> IEnumerable<TargetTypeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TargetTypeResource> IAsyncEnumerable<TargetTypeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
