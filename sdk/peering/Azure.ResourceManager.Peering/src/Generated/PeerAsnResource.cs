// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Peering
{
    /// <summary>
    /// A Class representing a PeerAsn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PeerAsnResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPeerAsnResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetPeerAsn method.
    /// </summary>
    public partial class PeerAsnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PeerAsnResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="peerAsnName"> The peerAsnName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string peerAsnName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _peerAsnClientDiagnostics;
        private readonly PeerAsnsRestOperations _peerAsnRestClient;
        private readonly PeerAsnData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Peering/peerAsns";

        /// <summary> Initializes a new instance of the <see cref="PeerAsnResource"/> class for mocking. </summary>
        protected PeerAsnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PeerAsnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PeerAsnResource(ArmClient client, PeerAsnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PeerAsnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PeerAsnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _peerAsnClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Peering", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string peerAsnApiVersion);
            _peerAsnRestClient = new PeerAsnsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, peerAsnApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PeerAsnData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PeerAsnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Get");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PeerAsnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Get");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PeerAsnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Delete");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Delete");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new PeeringArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new peer ASN or updates an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The peer ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PeerAsnResource>> UpdateAsync(WaitUntil waitUntil, PeerAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Update");
            scope.Start();
            try
            {
                var response = await _peerAsnRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new PeeringArmOperation<PeerAsnResource>(Response.FromValue(new PeerAsnResource(Client, response), response.GetRawResponse()));
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
        /// Creates a new peer ASN or updates an existing peer ASN with the specified name under the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Peering/peerAsns/{peerAsnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PeerAsns_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The peer ASN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PeerAsnResource> Update(WaitUntil waitUntil, PeerAsnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _peerAsnClientDiagnostics.CreateScope("PeerAsnResource.Update");
            scope.Start();
            try
            {
                var response = _peerAsnRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new PeeringArmOperation<PeerAsnResource>(Response.FromValue(new PeerAsnResource(Client, response), response.GetRawResponse()));
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
    }
}
