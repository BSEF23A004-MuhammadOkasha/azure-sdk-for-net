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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a ServiceBusNetworkRuleSet along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ServiceBusNetworkRuleSetResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetServiceBusNetworkRuleSetResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusNamespaceResource" /> using the GetServiceBusNetworkRuleSet method.
    /// </summary>
    public partial class ServiceBusNetworkRuleSetResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ServiceBusNetworkRuleSetResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/networkRuleSets/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _serviceBusNetworkRuleSetNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _serviceBusNetworkRuleSetNamespacesRestClient;
        private readonly ServiceBusNetworkRuleSetData _data;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNetworkRuleSetResource"/> class for mocking. </summary>
        protected ServiceBusNetworkRuleSetResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ServiceBusNetworkRuleSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ServiceBusNetworkRuleSetResource(ArmClient client, ServiceBusNetworkRuleSetData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNetworkRuleSetResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceBusNetworkRuleSetResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusNetworkRuleSetNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string serviceBusNetworkRuleSetNamespacesApiVersion);
            _serviceBusNetworkRuleSetNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusNetworkRuleSetNamespacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/networkRuleSets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusNetworkRuleSetData Data
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
        /// Gets NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_GetNetworkRuleSet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServiceBusNetworkRuleSetResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNetworkRuleSetNamespacesClientDiagnostics.CreateScope("ServiceBusNetworkRuleSetResource.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusNetworkRuleSetNamespacesRestClient.GetNetworkRuleSetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNetworkRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_GetNetworkRuleSet
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServiceBusNetworkRuleSetResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _serviceBusNetworkRuleSetNamespacesClientDiagnostics.CreateScope("ServiceBusNetworkRuleSetResource.Get");
            scope.Start();
            try
            {
                var response = _serviceBusNetworkRuleSetNamespacesRestClient.GetNetworkRuleSet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNetworkRuleSetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_CreateOrUpdateNetworkRuleSet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Namespace IpFilterRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusNetworkRuleSetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ServiceBusNetworkRuleSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNetworkRuleSetNamespacesClientDiagnostics.CreateScope("ServiceBusNetworkRuleSetResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusNetworkRuleSetNamespacesRestClient.CreateOrUpdateNetworkRuleSetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusNetworkRuleSetResource>(Response.FromValue(new ServiceBusNetworkRuleSetResource(Client, response), response.GetRawResponse()));
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
        /// Create or update NetworkRuleSet for a Namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/networkRuleSets/default
        /// Operation Id: Namespaces_CreateOrUpdateNetworkRuleSet
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Namespace IpFilterRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusNetworkRuleSetResource> CreateOrUpdate(WaitUntil waitUntil, ServiceBusNetworkRuleSetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNetworkRuleSetNamespacesClientDiagnostics.CreateScope("ServiceBusNetworkRuleSetResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusNetworkRuleSetNamespacesRestClient.CreateOrUpdateNetworkRuleSet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusNetworkRuleSetResource>(Response.FromValue(new ServiceBusNetworkRuleSetResource(Client, response), response.GetRawResponse()));
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
