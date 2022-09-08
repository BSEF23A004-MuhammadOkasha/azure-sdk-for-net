// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing a ScriptExecution along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ScriptExecutionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetScriptExecutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudResource" /> using the GetScriptExecution method.
    /// </summary>
    public partial class ScriptExecutionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ScriptExecutionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptExecutionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _scriptExecutionClientDiagnostics;
        private readonly ScriptExecutionsRestOperations _scriptExecutionRestClient;
        private readonly ScriptExecutionData _data;

        /// <summary> Initializes a new instance of the <see cref="ScriptExecutionResource"/> class for mocking. </summary>
        protected ScriptExecutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ScriptExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ScriptExecutionResource(ArmClient client, ScriptExecutionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ScriptExecutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ScriptExecutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scriptExecutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string scriptExecutionApiVersion);
            _scriptExecutionRestClient = new ScriptExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scriptExecutionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/scriptExecutions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ScriptExecutionData Data
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
        /// Get an script execution by name in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptExecutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Get");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an script execution by name in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptExecutionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Get");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancel a ScriptExecution in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Delete");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation(_scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Cancel a ScriptExecution in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Delete");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AvsArmOperation(_scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a script execution in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScriptExecutionResource>> UpdateAsync(WaitUntil waitUntil, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Update");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AvsArmOperation<ScriptExecutionResource>(new ScriptExecutionOperationSource(Client), _scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a script execution in a private cloud
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}
        /// Operation Id: ScriptExecutions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A script running in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScriptExecutionResource> Update(WaitUntil waitUntil, ScriptExecutionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.Update");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AvsArmOperation<ScriptExecutionResource>(new ScriptExecutionOperationSource(Client), _scriptExecutionClientDiagnostics, Pipeline, _scriptExecutionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Return the logs for a script execution resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}/getExecutionLogs
        /// Operation Id: ScriptExecutions_GetExecutionLogs
        /// </summary>
        /// <param name="scriptOutputStreamType"> Name of the desired output stream to return. If not provided, will return all. An empty array will return nothing. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptExecutionResource>> GetExecutionLogsAsync(IEnumerable<ScriptOutputStreamType> scriptOutputStreamType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.GetExecutionLogs");
            scope.Start();
            try
            {
                var response = await _scriptExecutionRestClient.GetExecutionLogsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptOutputStreamType, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return the logs for a script execution resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/scriptExecutions/{scriptExecutionName}/getExecutionLogs
        /// Operation Id: ScriptExecutions_GetExecutionLogs
        /// </summary>
        /// <param name="scriptOutputStreamType"> Name of the desired output stream to return. If not provided, will return all. An empty array will return nothing. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptExecutionResource> GetExecutionLogs(IEnumerable<ScriptOutputStreamType> scriptOutputStreamType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _scriptExecutionClientDiagnostics.CreateScope("ScriptExecutionResource.GetExecutionLogs");
            scope.Start();
            try
            {
                var response = _scriptExecutionRestClient.GetExecutionLogs(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, scriptOutputStreamType, cancellationToken);
                return Response.FromValue(new ScriptExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
