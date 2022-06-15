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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a NamespaceQueueAuthorizationRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NamespaceQueueAuthorizationRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNamespaceQueueAuthorizationRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusQueueResource" /> using the GetNamespaceQueueAuthorizationRule method.
    /// </summary>
    public partial class NamespaceQueueAuthorizationRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NamespaceQueueAuthorizationRuleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string queueName, string authorizationRuleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient;
        private readonly ServiceBusAuthorizationRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRuleResource"/> class for mocking. </summary>
        protected NamespaceQueueAuthorizationRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NamespaceQueueAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRuleResource(ArmClient client, ServiceBusAuthorizationRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NamespaceQueueAuthorizationRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NamespaceQueueAuthorizationRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
            _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, namespaceQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/queues/authorizationRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ServiceBusAuthorizationRuleData Data
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
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NamespaceQueueAuthorizationRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NamespaceQueueAuthorizationRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Get");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a queue authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
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
        /// Deletes a queue authorization rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
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
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NamespaceQueueAuthorizationRuleResource>> UpdateAsync(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<NamespaceQueueAuthorizationRuleResource>(Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NamespaceQueueAuthorizationRuleResource> Update(WaitUntil waitUntil, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.Update");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<NamespaceQueueAuthorizationRuleResource>(Response.FromValue(new NamespaceQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
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
        /// Primary and secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/ListKeys
        /// Operation Id: QueueAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AccessKeys>> GetKeysAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Primary and secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/ListKeys
        /// Operation Id: QueueAuthorizationRules_ListKeys
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessKeys> GetKeys(CancellationToken cancellationToken = default)
        {
            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.GetKeys");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: QueueAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<AccessKeys>> RegenerateKeysAsync(RegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = await _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.RegenerateKeysAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Regenerates the primary or secondary connection strings to the queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}/regenerateKeys
        /// Operation Id: QueueAuthorizationRules_RegenerateKeys
        /// </summary>
        /// <param name="content"> Parameters supplied to regenerate the authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<AccessKeys> RegenerateKeys(RegenerateAccessKeyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("NamespaceQueueAuthorizationRuleResource.RegenerateKeys");
            scope.Start();
            try
            {
                var response = _namespaceQueueAuthorizationRuleQueueAuthorizationRulesRestClient.RegenerateKeys(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
