// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationRecoveryServicesProvidersOperations.
    /// </summary>
    public static partial class ReplicationRecoveryServicesProvidersOperationsExtensions
    {
            /// <summary>
            /// Refresh details from the recovery services provider.
            /// </summary>
            /// <remarks>
            /// The operation to refresh the information from the recovery services
            /// provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static RecoveryServicesProvider RefreshProvider(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                return operations.RefreshProviderAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh details from the recovery services provider.
            /// </summary>
            /// <remarks>
            /// The operation to refresh the information from the recovery services
            /// provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoveryServicesProvider> RefreshProviderAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RefreshProviderWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes provider from fabric. Note: Deleting provider for any fabric other
            /// than SingleHost is unsupported. To maintain backward compatibility for
            /// released clients the object "deleteRspInput" is used (if the object is
            /// empty we assume that it is old client and continue the old behavior).
            /// </summary>
            /// <remarks>
            /// The operation to removes/delete(unregister) a recovery services provider
            /// from the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static void Delete(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                operations.DeleteAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes provider from fabric. Note: Deleting provider for any fabric other
            /// than SingleHost is unsupported. To maintain backward compatibility for
            /// released clients the object "deleteRspInput" is used (if the object is
            /// empty we assume that it is old client and continue the old behavior).
            /// </summary>
            /// <remarks>
            /// The operation to removes/delete(unregister) a recovery services provider
            /// from the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the details of a recovery services provider.
            /// </summary>
            /// <remarks>
            /// Gets the details of registered recovery services provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name
            /// </param>
            public static RecoveryServicesProvider Get(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                return operations.GetAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a recovery services provider.
            /// </summary>
            /// <remarks>
            /// Gets the details of registered recovery services provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoveryServicesProvider> GetAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purges recovery service provider from fabric
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) a recovery services provider from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static void Purge(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                operations.PurgeAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges recovery service provider from fabric
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) a recovery services provider from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PurgeAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PurgeWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers for the fabric.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers for the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name
            /// </param>
            public static IPage<RecoveryServicesProvider> ListByReplicationFabrics(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName)
            {
                return operations.ListByReplicationFabricsAsync(fabricName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers for the fabric.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers for the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryServicesProvider>> ListByReplicationFabricsAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsWithHttpMessagesAsync(fabricName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of registered recovery services providers in the vault. This
            /// is a view only api.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers in the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<RecoveryServicesProvider> List(this IReplicationRecoveryServicesProvidersOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers in the vault. This
            /// is a view only api.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers in the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryServicesProvider>> ListAsync(this IReplicationRecoveryServicesProvidersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Refresh details from the recovery services provider.
            /// </summary>
            /// <remarks>
            /// The operation to refresh the information from the recovery services
            /// provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static RecoveryServicesProvider BeginRefreshProvider(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                return operations.BeginRefreshProviderAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Refresh details from the recovery services provider.
            /// </summary>
            /// <remarks>
            /// The operation to refresh the information from the recovery services
            /// provider.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecoveryServicesProvider> BeginRefreshProviderAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRefreshProviderWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes provider from fabric. Note: Deleting provider for any fabric other
            /// than SingleHost is unsupported. To maintain backward compatibility for
            /// released clients the object "deleteRspInput" is used (if the object is
            /// empty we assume that it is old client and continue the old behavior).
            /// </summary>
            /// <remarks>
            /// The operation to removes/delete(unregister) a recovery services provider
            /// from the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static void BeginDelete(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                operations.BeginDeleteAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes provider from fabric. Note: Deleting provider for any fabric other
            /// than SingleHost is unsupported. To maintain backward compatibility for
            /// released clients the object "deleteRspInput" is used (if the object is
            /// empty we assume that it is old client and continue the old behavior).
            /// </summary>
            /// <remarks>
            /// The operation to removes/delete(unregister) a recovery services provider
            /// from the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Purges recovery service provider from fabric
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) a recovery services provider from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            public static void BeginPurge(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName)
            {
                operations.BeginPurgeAsync(fabricName, providerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges recovery service provider from fabric
            /// </summary>
            /// <remarks>
            /// The operation to purge(force delete) a recovery services provider from the
            /// vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='providerName'>
            /// Recovery services provider name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginPurgeAsync(this IReplicationRecoveryServicesProvidersOperations operations, string fabricName, string providerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginPurgeWithHttpMessagesAsync(fabricName, providerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers for the fabric.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers for the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecoveryServicesProvider> ListByReplicationFabricsNext(this IReplicationRecoveryServicesProvidersOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationFabricsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers for the fabric.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers for the specified fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryServicesProvider>> ListByReplicationFabricsNextAsync(this IReplicationRecoveryServicesProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationFabricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of registered recovery services providers in the vault. This
            /// is a view only api.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers in the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RecoveryServicesProvider> ListNext(this IReplicationRecoveryServicesProvidersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of registered recovery services providers in the vault. This
            /// is a view only api.
            /// </summary>
            /// <remarks>
            /// Lists the registered recovery services providers in the vault
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RecoveryServicesProvider>> ListNextAsync(this IReplicationRecoveryServicesProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
