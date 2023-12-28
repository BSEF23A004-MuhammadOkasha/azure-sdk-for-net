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

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A Class representing a GlobalRulestackFqdn along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GlobalRulestackFqdnResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGlobalRulestackFqdnResource method.
    /// Otherwise you can get one from its parent resource <see cref="GlobalRulestackResource"/> using the GetGlobalRulestackFqdn method.
    /// </summary>
    public partial class GlobalRulestackFqdnResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GlobalRulestackFqdnResource"/> instance. </summary>
        /// <param name="globalRulestackName"> The globalRulestackName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string globalRulestackName, string name)
        {
            var resourceId = $"/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics;
        private readonly FqdnListGlobalRulestackRestOperations _globalRulestackFqdnFqdnListGlobalRulestackRestClient;
        private readonly GlobalRulestackFqdnData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists";

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackFqdnResource"/> class for mocking. </summary>
        protected GlobalRulestackFqdnResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackFqdnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GlobalRulestackFqdnResource(ArmClient client, GlobalRulestackFqdnData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalRulestackFqdnResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GlobalRulestackFqdnResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PaloAltoNetworks.Ngfw", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string globalRulestackFqdnFqdnListGlobalRulestackApiVersion);
            _globalRulestackFqdnFqdnListGlobalRulestackRestClient = new FqdnListGlobalRulestackRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalRulestackFqdnFqdnListGlobalRulestackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GlobalRulestackFqdnData Data
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
        /// Get a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GlobalRulestackFqdnResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Get");
            scope.Start();
            try
            {
                var response = await _globalRulestackFqdnFqdnListGlobalRulestackRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackFqdnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GlobalRulestackFqdnResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Get");
            scope.Start();
            try
            {
                var response = _globalRulestackFqdnFqdnListGlobalRulestackRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalRulestackFqdnResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Delete");
            scope.Start();
            try
            {
                var response = await _globalRulestackFqdnFqdnListGlobalRulestackRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation(_globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Delete a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_Delete</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Delete");
            scope.Start();
            try
            {
                var response = _globalRulestackFqdnFqdnListGlobalRulestackRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new NgfwArmOperation(_globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateDeleteRequest(Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalRulestackFqdnResource>> UpdateAsync(WaitUntil waitUntil, GlobalRulestackFqdnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Update");
            scope.Start();
            try
            {
                var response = await _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new NgfwArmOperation<GlobalRulestackFqdnResource>(new GlobalRulestackFqdnOperationSource(Client), _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a FqdnListGlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}/fqdnlists/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FqdnListGlobalRulestack_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>PaloAltoNetworks.Cloudngfw/globalRulestacks/fqdnlists</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalRulestackFqdnResource> Update(WaitUntil waitUntil, GlobalRulestackFqdnData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics.CreateScope("GlobalRulestackFqdnResource.Update");
            scope.Start();
            try
            {
                var response = _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new NgfwArmOperation<GlobalRulestackFqdnResource>(new GlobalRulestackFqdnOperationSource(Client), _globalRulestackFqdnFqdnListGlobalRulestackClientDiagnostics, Pipeline, _globalRulestackFqdnFqdnListGlobalRulestackRestClient.CreateCreateOrUpdateRequest(Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
