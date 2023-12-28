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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a DiagnosticSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DiagnosticSettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDiagnosticSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetDiagnosticSetting method.
    /// </summary>
    public partial class DiagnosticSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiagnosticSettingResource"/> instance. </summary>
        /// <param name="resourceUri"> The resourceUri. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string name)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _diagnosticSettingClientDiagnostics;
        private readonly DiagnosticSettingsRestOperations _diagnosticSettingRestClient;
        private readonly DiagnosticSettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/diagnosticSettings";

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingResource"/> class for mocking. </summary>
        protected DiagnosticSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiagnosticSettingResource(ArmClient client, DiagnosticSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiagnosticSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diagnosticSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string diagnosticSettingApiVersion);
            _diagnosticSettingRestClient = new DiagnosticSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diagnosticSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiagnosticSettingData Data
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
        /// Gets the active diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the active diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes existing diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Delete");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(response);
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
        /// Deletes existing diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Delete");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(response);
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
        /// Creates or updates diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DiagnosticSettingResource>> UpdateAsync(WaitUntil waitUntil, DiagnosticSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingRestClient.CreateOrUpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DiagnosticSettingResource>(Response.FromValue(new DiagnosticSettingResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates diagnostic settings for the specified resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.Insights/diagnosticSettings/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiagnosticSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Insights/diagnosticSettings</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DiagnosticSettingResource> Update(WaitUntil waitUntil, DiagnosticSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _diagnosticSettingClientDiagnostics.CreateScope("DiagnosticSettingResource.Update");
            scope.Start();
            try
            {
                var response = _diagnosticSettingRestClient.CreateOrUpdate(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new MonitorArmOperation<DiagnosticSettingResource>(Response.FromValue(new DiagnosticSettingResource(Client, response), response.GetRawResponse()));
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
