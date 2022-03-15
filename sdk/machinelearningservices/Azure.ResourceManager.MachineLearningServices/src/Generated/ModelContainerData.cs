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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a ModelContainerData along with the instance operations that can be performed on it. </summary>
    public partial class ModelContainerData : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ModelContainerData"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _modelContainerDataModelContainersClientDiagnostics;
        private readonly ModelContainersRestOperations _modelContainerDataModelContainersRestClient;
        private readonly ModelContainerDataData _data;

        /// <summary> Initializes a new instance of the <see cref="ModelContainerData"/> class for mocking. </summary>
        protected ModelContainerData()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ModelContainerData"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ModelContainerData(ArmClient client, ModelContainerDataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ModelContainerData"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ModelContainerData(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _modelContainerDataModelContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearningServices", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string modelContainerDataModelContainersApiVersion);
            _modelContainerDataModelContainersRestClient = new ModelContainersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, modelContainerDataModelContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/models";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ModelContainerDataData Data
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

        /// <summary> Gets a collection of ModelVersionData in the ModelVersionData. </summary>
        /// <returns> An object representing collection of ModelVersionData and their operations over a ModelVersionData. </returns>
        public virtual ModelVersionDataCollection GetAllModelVersionData()
        {
            return new ModelVersionDataCollection(Client, Id);
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}
        /// Operation Id: ModelVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<ModelVersionData>> GetModelVersionDataAsync(string version, CancellationToken cancellationToken = default)
        {
            return await GetAllModelVersionData().GetAsync(version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}/versions/{version}
        /// Operation Id: ModelVersions_Get
        /// </summary>
        /// <param name="version"> Version identifier. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<ModelVersionData> GetModelVersionData(string version, CancellationToken cancellationToken = default)
        {
            return GetAllModelVersionData().Get(version, cancellationToken);
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}
        /// Operation Id: ModelContainers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelContainerData>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _modelContainerDataModelContainersClientDiagnostics.CreateScope("ModelContainerData.Get");
            scope.Start();
            try
            {
                var response = await _modelContainerDataModelContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ModelContainerData(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}
        /// Operation Id: ModelContainers_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelContainerData> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _modelContainerDataModelContainersClientDiagnostics.CreateScope("ModelContainerData.Get");
            scope.Start();
            try
            {
                var response = _modelContainerDataModelContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ModelContainerData(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete container.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}
        /// Operation Id: ModelContainers_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _modelContainerDataModelContainersClientDiagnostics.CreateScope("ModelContainerData.Delete");
            scope.Start();
            try
            {
                var response = await _modelContainerDataModelContainersRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningServicesArmOperation(response);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/models/{name}
        /// Operation Id: ModelContainers_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _modelContainerDataModelContainersClientDiagnostics.CreateScope("ModelContainerData.Delete");
            scope.Start();
            try
            {
                var response = _modelContainerDataModelContainersRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningServicesArmOperation(response);
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
    }
}
