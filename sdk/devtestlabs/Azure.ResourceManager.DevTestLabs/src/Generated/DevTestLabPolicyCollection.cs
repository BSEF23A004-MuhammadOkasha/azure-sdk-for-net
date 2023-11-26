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

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary>
    /// A class representing a collection of <see cref="DevTestLabPolicyResource"/> and their operations.
    /// Each <see cref="DevTestLabPolicyResource"/> in the collection will belong to the same instance of <see cref="DevTestLabResource"/>.
    /// To get a <see cref="DevTestLabPolicyCollection"/> instance call the GetDevTestLabPolicies method from an instance of <see cref="DevTestLabResource"/>.
    /// </summary>
    public partial class DevTestLabPolicyCollection : ArmCollection, IEnumerable<DevTestLabPolicyResource>, IAsyncEnumerable<DevTestLabPolicyResource>
    {
        private readonly ClientDiagnostics _devTestLabPolicyPoliciesClientDiagnostics;
        private readonly PoliciesRestOperations _devTestLabPolicyPoliciesRestClient;
        private readonly string _policySetName;

        /// <summary> Initializes a new instance of the <see cref="DevTestLabPolicyCollection"/> class for mocking. </summary>
        protected DevTestLabPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DevTestLabPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="policySetName"> The name of the policy set. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policySetName"/> is an empty string, and was expected to be non-empty. </exception>
        internal DevTestLabPolicyCollection(ArmClient client, ResourceIdentifier id, string policySetName) : base(client, id)
        {
            _policySetName = policySetName;
            _devTestLabPolicyPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DevTestLabPolicyResource.ResourceType, out string devTestLabPolicyPoliciesApiVersion);
            _devTestLabPolicyPoliciesRestClient = new PoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, devTestLabPolicyPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DevTestLabResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DevTestLabResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or replace an existing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="data"> A Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DevTestLabPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DevTestLabPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _devTestLabPolicyPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevTestLabsArmOperation<DevTestLabPolicyResource>(Response.FromValue(new DevTestLabPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create or replace an existing policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="data"> A Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DevTestLabPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string name, DevTestLabPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _devTestLabPolicyPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, data, cancellationToken);
                var operation = new DevTestLabsArmOperation<DevTestLabPolicyResource>(Response.FromValue(new DevTestLabPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DevTestLabPolicyResource>> GetAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _devTestLabPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DevTestLabPolicyResource> Get(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _devTestLabPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DevTestLabPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List policies in a given policy set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabPolicyResource> GetAllAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabPolicyPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabPolicyPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabPolicyResource(Client, DevTestLabPolicyData.DeserializeDevTestLabPolicyData(e)), _devTestLabPolicyPoliciesClientDiagnostics, Pipeline, "DevTestLabPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List policies in a given policy set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabPolicyResource> GetAll(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _devTestLabPolicyPoliciesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _devTestLabPolicyPoliciesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new DevTestLabPolicyResource(Client, DevTestLabPolicyData.DeserializeDevTestLabPolicyData(e)), _devTestLabPolicyPoliciesClientDiagnostics, Pipeline, "DevTestLabPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _devTestLabPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _devTestLabPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<NullableResponse<DevTestLabPolicyResource>> GetIfExistsAsync(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _devTestLabPolicyPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevTestLab/labs/{labName}/policysets/{policySetName}/policies/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Policies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=description)'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual NullableResponse<DevTestLabPolicyResource> GetIfExists(string name, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _devTestLabPolicyPoliciesClientDiagnostics.CreateScope("DevTestLabPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _devTestLabPolicyPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _policySetName, name, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DevTestLabPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new DevTestLabPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DevTestLabPolicyResource> IEnumerable<DevTestLabPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DevTestLabPolicyResource> IAsyncEnumerable<DevTestLabPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
