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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningModelContainer along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MachineLearningModelContainerResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMachineLearningModelContainerResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningWorkspaceResource"/> using the GetMachineLearningModelContainer method.
    /// </summary>
    public partial class MachineLearningModelContainerResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningModelContainerResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningModelContainerModelContainersClientDiagnostics;
        private readonly ModelContainersRestOperations _machineLearningModelContainerModelContainersRestClient;
        private readonly MachineLearningModelContainerData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/models";

        /// <summary> Initializes a new instance of the <see cref="MachineLearningModelContainerResource"/> class for mocking. </summary>
        protected MachineLearningModelContainerResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningModelContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningModelContainerResource(ArmClient client, MachineLearningModelContainerData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningModelContainerResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningModelContainerResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningModelContainerModelContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningModelContainerModelContainersApiVersion);
            _machineLearningModelContainerModelContainersRestClient = new ModelContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningModelContainerModelContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningModelContainerData Data
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

        /// <summary> Gets a collection of MachineLearningModelVersionResources in the MachineLearningModelContainer. </summary>
        /// <returns> An object representing collection of MachineLearningModelVersionResources and their operations over a MachineLearningModelVersionResource. </returns>
        public virtual MachineLearningModelVersionCollection GetMachineLearningModelVersions()
        {
            return GetCachedClient(client => new MachineLearningModelVersionCollection(client, Id));
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MachineLearningModelVersionResource>> GetMachineLearningModelVersionAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetMachineLearningModelVersions().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelVersions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MachineLearningModelVersionResource> GetMachineLearningModelVersion(string version, CancellationToken cancellationToken = default)
        {
            return GetMachineLearningModelVersions().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningModelContainerResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningModelContainerModelContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningModelContainerResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningModelContainerModelContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningModelContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningModelContainerModelContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningModelContainerModelContainersRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation(response, rehydrationToken);
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
        /// Delete container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningModelContainerModelContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _machineLearningModelContainerModelContainersRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation(response, rehydrationToken);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningModelContainerResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningModelContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningModelContainerModelContainersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _machineLearningModelContainerModelContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningModelContainerResource>(Response.FromValue(new MachineLearningModelContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ModelContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
<<<<<<< HEAD
        /// <description>2024-04-01</description>
=======
        /// <description>2024-07-01-preview</description>
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MachineLearningModelContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Container entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningModelContainerResource> Update(WaitUntil waitUntil, MachineLearningModelContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningModelContainerModelContainersClientDiagnostics.CreateScope("MachineLearningModelContainerResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningModelContainerModelContainersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _machineLearningModelContainerModelContainersRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MachineLearningArmOperation<MachineLearningModelContainerResource>(Response.FromValue(new MachineLearningModelContainerResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
