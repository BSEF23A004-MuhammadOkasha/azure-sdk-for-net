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

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A Class representing a HciHybridIdentityMetadata along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="HciHybridIdentityMetadataResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetHciHybridIdentityMetadataResource method.
    /// Otherwise you can get one from its parent resource <see cref="HciVirtualMachineResource" /> using the GetHciHybridIdentityMetadata method.
    /// </summary>
    public partial class HciHybridIdentityMetadataResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HciHybridIdentityMetadataResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineName, string metadataName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics;
        private readonly HybridIdentityMetadataRestOperations _hciHybridIdentityMetadataHybridIdentityMetadataRestClient;
        private readonly HciHybridIdentityMetadataData _data;

        /// <summary> Initializes a new instance of the <see cref="HciHybridIdentityMetadataResource"/> class for mocking. </summary>
        protected HciHybridIdentityMetadataResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "HciHybridIdentityMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HciHybridIdentityMetadataResource(ArmClient client, HciHybridIdentityMetadataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HciHybridIdentityMetadataResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HciHybridIdentityMetadataResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hciHybridIdentityMetadataHybridIdentityMetadataApiVersion);
            _hciHybridIdentityMetadataHybridIdentityMetadataRestClient = new HybridIdentityMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciHybridIdentityMetadataHybridIdentityMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AzureStackHCI/virtualMachines/hybridIdentityMetadata";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HciHybridIdentityMetadataData Data
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
        /// Implements HybridIdentityMetadata GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HciHybridIdentityMetadataResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Get");
            scope.Start();
            try
            {
                var response = await _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciHybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements HybridIdentityMetadata GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HciHybridIdentityMetadataResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Get");
            scope.Start();
            try
            {
                var response = _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciHybridIdentityMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements HybridIdentityMetadata DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Delete");
            scope.Start();
            try
            {
                var response = await _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation(response);
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
        /// Implements HybridIdentityMetadata DELETE method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Delete");
            scope.Start();
            try
            {
                var response = _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new HciArmOperation(response);
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
        /// Create Or Update HybridIdentityMetadata.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HciHybridIdentityMetadataResource>> UpdateAsync(WaitUntil waitUntil, HciHybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Update");
            scope.Start();
            try
            {
                var response = await _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<HciHybridIdentityMetadataResource>(Response.FromValue(new HciHybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
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
        /// Create Or Update HybridIdentityMetadata.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/virtualMachines/{virtualMachineName}/hybridIdentityMetadata/{metadataName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridIdentityMetadata_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HciHybridIdentityMetadataResource> Update(WaitUntil waitUntil, HciHybridIdentityMetadataData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciHybridIdentityMetadataHybridIdentityMetadataClientDiagnostics.CreateScope("HciHybridIdentityMetadataResource.Update");
            scope.Start();
            try
            {
                var response = _hciHybridIdentityMetadataHybridIdentityMetadataRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new HciArmOperation<HciHybridIdentityMetadataResource>(Response.FromValue(new HciHybridIdentityMetadataResource(Client, response), response.GetRawResponse()));
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
