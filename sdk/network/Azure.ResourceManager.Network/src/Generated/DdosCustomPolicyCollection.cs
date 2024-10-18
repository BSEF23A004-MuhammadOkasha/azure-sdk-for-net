// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="DdosCustomPolicyResource"/> and their operations.
    /// Each <see cref="DdosCustomPolicyResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DdosCustomPolicyCollection"/> instance call the GetDdosCustomPolicies method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DdosCustomPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _ddosCustomPolicyClientDiagnostics;
        private readonly DdosCustomPoliciesRestOperations _ddosCustomPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyCollection"/> class for mocking. </summary>
        protected DdosCustomPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DdosCustomPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ddosCustomPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", DdosCustomPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DdosCustomPolicyResource.ResourceType, out string ddosCustomPolicyApiVersion);
            _ddosCustomPolicyRestClient = new DdosCustomPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, ddosCustomPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DDoS custom policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="data"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DdosCustomPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ddosCustomPolicyName, DdosCustomPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<DdosCustomPolicyResource>(new DdosCustomPolicyOperationSource(Client), _ddosCustomPolicyClientDiagnostics, Pipeline, _ddosCustomPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a DDoS custom policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="data"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DdosCustomPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string ddosCustomPolicyName, DdosCustomPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, data, cancellationToken);
                var operation = new NetworkArmOperation<DdosCustomPolicyResource>(new DdosCustomPolicyOperationSource(Client), _ddosCustomPolicyClientDiagnostics, Pipeline, _ddosCustomPolicyRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified DDoS custom policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<Response<DdosCustomPolicyResource>> GetAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified DDoS custom policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<DdosCustomPolicyResource> Get(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<DdosCustomPolicyResource>> GetIfExistsAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ddosCustomPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DdosCustomPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicyResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ddosCustomPolicies/{ddosCustomPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DdosCustomPolicies_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DdosCustomPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ddosCustomPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public virtual NullableResponse<DdosCustomPolicyResource> GetIfExists(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ddosCustomPolicyName, nameof(ddosCustomPolicyName));

            using var scope = _ddosCustomPolicyClientDiagnostics.CreateScope("DdosCustomPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ddosCustomPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DdosCustomPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new DdosCustomPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
