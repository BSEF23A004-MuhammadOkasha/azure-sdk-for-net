// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ApplicationSecurityGroup and their operations over its parent. </summary>
    public partial class ApplicationSecurityGroupContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ApplicationSecurityGroupsRestOperations _applicationSecurityGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApplicationSecurityGroupContainer"/> class for mocking. </summary>
        protected ApplicationSecurityGroupContainer()
        {
        }

        /// <summary> Initializes a new instance of ApplicationSecurityGroupContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ApplicationSecurityGroupContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _applicationSecurityGroupsRestClient = new ApplicationSecurityGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ApplicationSecurityGroupCreateOrUpdateOperation CreateOrUpdate(string applicationSecurityGroupName, ApplicationSecurityGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupsRestClient.CreateOrUpdate(Id.ResourceGroupName, applicationSecurityGroupName, parameters, cancellationToken);
                var operation = new ApplicationSecurityGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _applicationSecurityGroupsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationSecurityGroupName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ApplicationSecurityGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string applicationSecurityGroupName, ApplicationSecurityGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupsRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, applicationSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationSecurityGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _applicationSecurityGroupsRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationSecurityGroupName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<ApplicationSecurityGroup> Get(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.Get");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupsRestClient.Get(Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApplicationSecurityGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<ApplicationSecurityGroup>> GetAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.Get");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupsRestClient.GetAsync(Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ApplicationSecurityGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<ApplicationSecurityGroup> GetIfExists(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _applicationSecurityGroupsRestClient.Get(Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ApplicationSecurityGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ApplicationSecurityGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<ApplicationSecurityGroup>> GetIfExistsAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _applicationSecurityGroupsRestClient.GetAsync(Id.ResourceGroupName, applicationSecurityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ApplicationSecurityGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new ApplicationSecurityGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(applicationSecurityGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationSecurityGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(applicationSecurityGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApplicationSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApplicationSecurityGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationSecurityGroupsRestClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _applicationSecurityGroupsRestClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApplicationSecurityGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApplicationSecurityGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationSecurityGroupsRestClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _applicationSecurityGroupsRestClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ApplicationSecurityGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ApplicationSecurityGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationSecurityGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ApplicationSecurityGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationSecurityGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationSecurityGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ApplicationSecurityGroup, ApplicationSecurityGroupData> Construct() { }
    }
}
