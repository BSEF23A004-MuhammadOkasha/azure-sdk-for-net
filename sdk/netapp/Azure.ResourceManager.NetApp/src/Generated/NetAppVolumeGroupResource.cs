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

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A Class representing a NetAppVolumeGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="NetAppVolumeGroupResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetNetAppVolumeGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="NetAppAccountResource"/> using the GetNetAppVolumeGroup method.
    /// </summary>
    public partial class NetAppVolumeGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetAppVolumeGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="volumeGroupName"> The volumeGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string volumeGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _netAppVolumeGroupVolumeGroupsClientDiagnostics;
        private readonly VolumeGroupsRestOperations _netAppVolumeGroupVolumeGroupsRestClient;
        private readonly NetAppVolumeGroupData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.NetApp/netAppAccounts/volumeGroups";

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeGroupResource"/> class for mocking. </summary>
        protected NetAppVolumeGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetAppVolumeGroupResource(ArmClient client, NetAppVolumeGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetAppVolumeGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppVolumeGroupVolumeGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string netAppVolumeGroupVolumeGroupsApiVersion);
            _netAppVolumeGroupVolumeGroupsRestClient = new VolumeGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeGroupVolumeGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetAppVolumeGroupData Data
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
        /// Get details of the specified volume group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetAppVolumeGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified volume group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetAppVolumeGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Get");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the specified volume group only if there are no volumes under volume group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation(_netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Delete the specified volume group only if there are no volumes under volume group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NetAppArmOperation(_netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create a volume group along with specified volumes
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppVolumeGroupResource>> UpdateAsync(WaitUntil waitUntil, NetAppVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _netAppVolumeGroupVolumeGroupsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppVolumeGroupResource>(new NetAppVolumeGroupOperationSource(Client), _netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create a volume group along with specified volumes
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/volumeGroups/{volumeGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeGroups_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.NetApp/netAppAccounts/volumeGroups</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Volume Group object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppVolumeGroupResource> Update(WaitUntil waitUntil, NetAppVolumeGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeGroupVolumeGroupsClientDiagnostics.CreateScope("NetAppVolumeGroupResource.Update");
            scope.Start();
            try
            {
                var response = _netAppVolumeGroupVolumeGroupsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppVolumeGroupResource>(new NetAppVolumeGroupOperationSource(Client), _netAppVolumeGroupVolumeGroupsClientDiagnostics, Pipeline, _netAppVolumeGroupVolumeGroupsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
