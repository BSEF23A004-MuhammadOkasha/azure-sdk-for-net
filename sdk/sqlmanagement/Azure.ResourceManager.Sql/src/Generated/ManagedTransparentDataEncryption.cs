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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedTransparentDataEncryption along with the instance operations that can be performed on it. </summary>
    public partial class ManagedTransparentDataEncryption : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedTransparentDataEncryption"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string tdeName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionClientDiagnostics;
        private readonly ManagedDatabaseTransparentDataEncryptionRestOperations _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionRestClient;
        private readonly ManagedTransparentDataEncryptionData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedTransparentDataEncryption"/> class for mocking. </summary>
        protected ManagedTransparentDataEncryption()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedTransparentDataEncryption"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedTransparentDataEncryption(ArmClient client, ManagedTransparentDataEncryptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedTransparentDataEncryption"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedTransparentDataEncryption(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionApiVersion);
            _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionRestClient = new ManagedDatabaseTransparentDataEncryptionRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/transparentDataEncryption";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedTransparentDataEncryptionData Data
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
        /// Gets a managed database&apos;s transparent data encryption.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// Operation Id: ManagedDatabaseTransparentDataEncryption_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedTransparentDataEncryption>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionClientDiagnostics.CreateScope("ManagedTransparentDataEncryption.Get");
            scope.Start();
            try
            {
                var response = await _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedTransparentDataEncryption(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s transparent data encryption.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/transparentDataEncryption/{tdeName}
        /// Operation Id: ManagedDatabaseTransparentDataEncryption_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedTransparentDataEncryption> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionClientDiagnostics.CreateScope("ManagedTransparentDataEncryption.Get");
            scope.Start();
            try
            {
                var response = _managedTransparentDataEncryptionManagedDatabaseTransparentDataEncryptionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedTransparentDataEncryption(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
