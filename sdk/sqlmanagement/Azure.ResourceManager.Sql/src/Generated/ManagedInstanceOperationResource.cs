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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedInstanceOperation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedInstanceOperationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedInstanceOperationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedInstanceResource" /> using the GetManagedInstanceOperation method.
    /// </summary>
    public partial class ManagedInstanceOperationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedInstanceOperationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string operationId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedInstanceOperationClientDiagnostics;
        private readonly ManagedInstanceRestOperations _managedInstanceOperationRestClient;
        private readonly ManagedInstanceOperationData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperationResource"/> class for mocking. </summary>
        protected ManagedInstanceOperationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedInstanceOperationResource(ArmClient client, ManagedInstanceOperationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceOperationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceOperationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceOperationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedInstanceOperationApiVersion);
            _managedInstanceOperationRestClient = new ManagedInstanceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceOperationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/operations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedInstanceOperationData Data
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
        /// Gets a management operation on a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedInstanceOperationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationResource.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a management operation on a managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}
        /// Operation Id: ManagedInstanceOperations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceOperationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationResource.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceOperationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels the asynchronous operation on the managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}/cancel
        /// Operation Id: ManagedInstanceOperations_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationResource.Cancel");
            scope.Start();
            try
            {
                var response = await _managedInstanceOperationRestClient.CancelAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels the asynchronous operation on the managed instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/operations/{operationId}/cancel
        /// Operation Id: ManagedInstanceOperations_Cancel
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Cancel(CancellationToken cancellationToken = default)
        {
            using var scope = _managedInstanceOperationClientDiagnostics.CreateScope("ManagedInstanceOperationResource.Cancel");
            scope.Start();
            try
            {
                var response = _managedInstanceOperationRestClient.Cancel(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Guid.Parse(Id.Name), cancellationToken);
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
