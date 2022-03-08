// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class representing collection of StorageQueue and their operations over its parent. </summary>
    public partial class StorageQueueCollection : ArmCollection, IEnumerable<StorageQueue>, IAsyncEnumerable<StorageQueue>
    {
        private readonly ClientDiagnostics _storageQueueQueueClientDiagnostics;
        private readonly QueueRestOperations _storageQueueQueueRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageQueueCollection"/> class for mocking. </summary>
        protected StorageQueueCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageQueueCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageQueueCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageQueueQueueClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Storage", StorageQueue.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(StorageQueue.ResourceType, out string storageQueueQueueApiVersion);
            _storageQueueQueueRestClient = new QueueRestOperations(_storageQueueQueueClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, storageQueueQueueApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != QueueService.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, QueueService.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new queue with the specified queue name, under the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="queue"/> is null. </exception>
        public async virtual Task<ArmOperation<StorageQueue>> CreateOrUpdateAsync(bool waitForCompletion, string queueName, StorageQueueData queue, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            Argument.AssertNotNull(queue, nameof(queue));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageQueueQueueRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, queue, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<StorageQueue>(Response.FromValue(new StorageQueue(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Creates a new queue with the specified queue name, under the specified account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Create
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="queue"> Queue properties and metadata to be created with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> or <paramref name="queue"/> is null. </exception>
        public virtual ArmOperation<StorageQueue> CreateOrUpdate(bool waitForCompletion, string queueName, StorageQueueData queue, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));
            Argument.AssertNotNull(queue, nameof(queue));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageQueueQueueRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, queue, cancellationToken);
                var operation = new StorageArmOperation<StorageQueue>(Response.FromValue(new StorageQueue(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Gets the queue with the specified queue name, under the specified account if it exists.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<StorageQueue>> GetAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageQueueQueueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _storageQueueQueueClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new StorageQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the queue with the specified queue name, under the specified account if it exists.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<StorageQueue> Get(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.Get");
            scope.Start();
            try
            {
                var response = _storageQueueQueueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, cancellationToken);
                if (response.Value == null)
                    throw _storageQueueQueueClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of all the queues under the specified storage account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues
        /// Operation Id: Queue_List
        /// </summary>
        /// <param name="maxpagesize"> Optional, a maximum number of queues that should be included in a list queue response. </param>
        /// <param name="filter"> Optional, When specified, only the queues with a name starting with the given filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageQueue> GetAllAsync(string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<StorageQueue>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageQueueQueueRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StorageQueue>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _storageQueueQueueRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of all the queues under the specified storage account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues
        /// Operation Id: Queue_List
        /// </summary>
        /// <param name="maxpagesize"> Optional, a maximum number of queues that should be included in a list queue response. </param>
        /// <param name="filter"> Optional, When specified, only the queues with a name starting with the given filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageQueue" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageQueue> GetAll(string maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<StorageQueue> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageQueueQueueRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StorageQueue> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _storageQueueQueueRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, maxpagesize, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StorageQueue(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(queueName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<bool> Exists(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(queueName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public async virtual Task<Response<StorageQueue>> GetIfExistsAsync(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageQueueQueueRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<StorageQueue>(null, response.GetRawResponse());
                return Response.FromValue(new StorageQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/queueServices/default/queues/{queueName}
        /// Operation Id: Queue_Get
        /// </summary>
        /// <param name="queueName"> A queue name must be unique within a storage account and must be between 3 and 63 characters.The name must comprise of lowercase alphanumeric and dash(-) characters only, it should begin and end with an alphanumeric character and it cannot have two consecutive dash(-) characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="queueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="queueName"/> is null. </exception>
        public virtual Response<StorageQueue> GetIfExists(string queueName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(queueName, nameof(queueName));

            using var scope = _storageQueueQueueClientDiagnostics.CreateScope("StorageQueueCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageQueueQueueRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, queueName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<StorageQueue>(null, response.GetRawResponse());
                return Response.FromValue(new StorageQueue(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageQueue> IEnumerable<StorageQueue>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageQueue> IAsyncEnumerable<StorageQueue>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
