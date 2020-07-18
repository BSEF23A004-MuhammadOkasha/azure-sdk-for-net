// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;

namespace Azure.Management.Storage
{
    /// <summary> The ObjectReplicationPolicies service client. </summary>
    public partial class ObjectReplicationPoliciesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ObjectReplicationPoliciesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ObjectReplicationPoliciesOperations for mocking. </summary>
        protected ObjectReplicationPoliciesOperations()
        {
        }
        /// <summary> Initializes a new instance of ObjectReplicationPoliciesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ObjectReplicationPoliciesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-06-01")
        {
            RestClient = new ObjectReplicationPoliciesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ObjectReplicationPolicy>> GetAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, accountName, objectReplicationPolicyId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the object replication policy of the storage account by policy ID. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ObjectReplicationPolicy> Get(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, accountName, objectReplicationPolicyId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ObjectReplicationPolicy>> CreateOrUpdateAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, ObjectReplicationPolicy properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, accountName, objectReplicationPolicyId, properties, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update the object replication policy of the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ObjectReplicationPolicy> CreateOrUpdate(string resourceGroupName, string accountName, string objectReplicationPolicyId, ObjectReplicationPolicy properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, accountName, objectReplicationPolicyId, properties, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the object replication policy associated with the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, accountName, objectReplicationPolicyId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the object replication policy associated with the specified storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="objectReplicationPolicyId"> The ID of object replication policy or &apos;default&apos; if the policy ID is unknown. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string accountName, string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, accountName, objectReplicationPolicyId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ObjectReplicationPolicy> ListAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            async Task<Page<ObjectReplicationPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> List the object replication policies associated with the storage account. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ObjectReplicationPolicy> List(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            Page<ObjectReplicationPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ObjectReplicationPoliciesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, accountName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
