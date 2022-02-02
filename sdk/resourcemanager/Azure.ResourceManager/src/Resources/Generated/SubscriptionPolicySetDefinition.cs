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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a SubscriptionPolicySetDefinition along with the instance operations that can be performed on it. </summary>
    public partial class SubscriptionPolicySetDefinition : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionPolicySetDefinition"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string policySetDefinitionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient;
        private readonly PolicySetDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinition"/> class for mocking. </summary>
        protected SubscriptionPolicySetDefinition()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionPolicySetDefinition"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionPolicySetDefinition(ArmClient armClient, PolicySetDefinitionData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPolicySetDefinition"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionPolicySetDefinition(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
            _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(_subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subscriptionPolicySetDefinitionPolicySetDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policySetDefinitions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PolicySetDefinitionData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_Get
        /// <summary> This operation retrieves the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SubscriptionPolicySetDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionPolicySetDefinition(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_Get
        /// <summary> This operation retrieves the policy set definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionPolicySetDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPolicySetDefinition(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_Delete
        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SubscriptionPolicySetDefinitionDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.DeleteAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionPolicySetDefinitionDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policySetDefinitions/{policySetDefinitionName}
        /// OperationId: PolicySetDefinitions_Delete
        /// <summary> This operation deletes the policy set definition in the given subscription with the given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SubscriptionPolicySetDefinitionDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionPolicySetDefinitionPolicySetDefinitionsRestClient.Delete(Id.SubscriptionId, Id.Name, cancellationToken);
                var operation = new SubscriptionPolicySetDefinitionDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionPolicySetDefinitionPolicySetDefinitionsClientDiagnostics.CreateScope("SubscriptionPolicySetDefinition.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
