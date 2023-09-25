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
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementSubscriptionResource" /> and their operations.
    /// Each <see cref="ApiManagementSubscriptionResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementSubscriptionCollection" /> instance call the GetApiManagementSubscriptions method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementSubscriptionCollection : ArmCollection, IEnumerable<ApiManagementSubscriptionResource>, IAsyncEnumerable<ApiManagementSubscriptionResource>
    {
        private readonly ClientDiagnostics _apiManagementSubscriptionSubscriptionClientDiagnostics;
        private readonly SubscriptionRestOperations _apiManagementSubscriptionSubscriptionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementSubscriptionCollection"/> class for mocking. </summary>
        protected ApiManagementSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementSubscriptionSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementSubscriptionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementSubscriptionResource.ResourceType, out string apiManagementSubscriptionSubscriptionApiVersion);
            _apiManagementSubscriptionSubscriptionRestClient = new SubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementSubscriptionSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the subscription of specified user to the specified product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sid, ApiManagementSubscriptionCreateOrUpdateContent content, bool? notify = null, ETag? ifMatch = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, content, notify, ifMatch, appType, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementSubscriptionResource>(Response.FromValue(new ApiManagementSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the subscription of specified user to the specified product.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="content"> Create parameters. </param>
        /// <param name="notify">
        /// Notify change in Subscription State.
        ///  - If false, do not send any email notification for change of state of subscription
        ///  - If true, send email notification of change of state of subscription
        /// </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="appType"> Determines the type of application which send the create user request. Default is legacy publisher portal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string sid, ApiManagementSubscriptionCreateOrUpdateContent content, bool? notify = null, ETag? ifMatch = null, AppType? appType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, content, notify, ifMatch, appType, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementSubscriptionResource>(Response.FromValue(new ApiManagementSubscriptionResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<ApiManagementSubscriptionResource>> GetAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified Subscription entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<ApiManagementSubscriptionResource> Get(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all subscriptions of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| user | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementSubscriptionResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementSubscriptionSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementSubscriptionSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _apiManagementSubscriptionSubscriptionClientDiagnostics, Pipeline, "ApiManagementSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all subscriptions of the API Management service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| displayName | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| stateComment | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| ownerId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| scope | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| userId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| productId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| state | filter | eq |     |&lt;/br&gt;| user | expand |     |     |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementSubscriptionResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementSubscriptionSubscriptionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementSubscriptionSubscriptionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementSubscriptionResource(Client, SubscriptionContractData.DeserializeSubscriptionContractData(e)), _apiManagementSubscriptionSubscriptionClientDiagnostics, Pipeline, "ApiManagementSubscriptionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual Response<bool> Exists(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementSubscriptionResource>> GetIfExistsAsync(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementSubscriptionSubscriptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/subscriptions/{sid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscription_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sid"> Subscription entity Identifier. The entity represents the association between a user and a product in API Management. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sid"/> is null. </exception>
        public virtual NullableResponse<ApiManagementSubscriptionResource> GetIfExists(string sid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sid, nameof(sid));

            using var scope = _apiManagementSubscriptionSubscriptionClientDiagnostics.CreateScope("ApiManagementSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementSubscriptionSubscriptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sid, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementSubscriptionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementSubscriptionResource> IEnumerable<ApiManagementSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementSubscriptionResource> IAsyncEnumerable<ApiManagementSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
