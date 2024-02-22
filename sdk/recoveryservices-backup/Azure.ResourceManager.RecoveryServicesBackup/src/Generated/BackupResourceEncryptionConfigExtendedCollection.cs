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
using Azure.ResourceManager.RecoveryServicesBackup.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A class representing a collection of <see cref="BackupResourceEncryptionConfigExtendedResource"/> and their operations.
    /// Each <see cref="BackupResourceEncryptionConfigExtendedResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="BackupResourceEncryptionConfigExtendedCollection"/> instance call the GetBackupResourceEncryptionConfigExtendeds method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class BackupResourceEncryptionConfigExtendedCollection : ArmCollection
    {
        private readonly ClientDiagnostics _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics;
        private readonly BackupResourceEncryptionConfigsRestOperations _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BackupResourceEncryptionConfigExtendedCollection"/> class for mocking. </summary>
        protected BackupResourceEncryptionConfigExtendedCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupResourceEncryptionConfigExtendedCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BackupResourceEncryptionConfigExtendedCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", BackupResourceEncryptionConfigExtendedResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BackupResourceEncryptionConfigExtendedResource.ResourceType, out string backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsApiVersion);
            _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient = new BackupResourceEncryptionConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Updates Vault encryption config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="content"> Vault encryption input config request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string vaultName, BackupResourceEncryptionConfigExtendedCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesBackupArmOperation(response);
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
        /// Updates Vault encryption config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="content"> Vault encryption input config request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string vaultName, BackupResourceEncryptionConfigExtendedCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, vaultName, content, cancellationToken);
                var operation = new RecoveryServicesBackupArmOperation(response);
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
        /// Fetches Vault Encryption config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<BackupResourceEncryptionConfigExtendedResource>> GetAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.Get");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches Vault Encryption config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<BackupResourceEncryptionConfigExtendedResource> Get(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.Get");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.Exists");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual Response<bool> Exists(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.Exists");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual async Task<NullableResponse<BackupResourceEncryptionConfigExtendedResource>> GetIfExistsAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BackupResourceEncryptionConfigExtendedResource>(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupEncryptionConfigs/backupResourceEncryptionConfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BackupResourceEncryptionConfigs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BackupResourceEncryptionConfigExtendedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        public virtual NullableResponse<BackupResourceEncryptionConfigExtendedResource> GetIfExists(string vaultName, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (vaultName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(vaultName));
            }

            using var scope = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsClientDiagnostics.CreateScope("BackupResourceEncryptionConfigExtendedCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _backupResourceEncryptionConfigExtendedBackupResourceEncryptionConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vaultName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BackupResourceEncryptionConfigExtendedResource>(response.GetRawResponse());
                return Response.FromValue(new BackupResourceEncryptionConfigExtendedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
